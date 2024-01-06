using MongoDB.Driver;
using Project.Models;

namespace Project.Controllers
{

    public class ReportController
    {
        private readonly IMongoCollection<Report> _reportCollection;

        public ReportController(string connectionString, string databaseName, string collectionName)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            _reportCollection = database.GetCollection<Report>(collectionName);
        }

        public void AddReport(Report report)
        {
            try
            {
                _reportCollection.InsertOne(report);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Report? GetReport(int reportId)
        {
            try
            {
                return _reportCollection.Find(r => r.ReportId == reportId).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public List<Report> GetAllReports()
        {
            try
            {
                return _reportCollection.Find(_ => true).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting all reports: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Report>();
            }
        }
    }

}