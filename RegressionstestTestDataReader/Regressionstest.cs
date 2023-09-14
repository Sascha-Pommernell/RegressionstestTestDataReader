using TestDataReaders.CSVReader;

namespace RegressionstestTestDataReader
{
    [TestFixture]
    public class Regressionstest
    {
        private static string csvFilePath = @"C:\source\RegressionstestTestDataReader\RegressionstestTestDataReader\Testdata\Mappe1.CSV";        
        private string Anrede = "Herr";
        private string Titel = "";
        private string Vorname = "Martin";
        private string Nachname = "";
        private string Sprache = "";
        private string Benutzername = "martin3";
        private string EMailAdresse = "EDE-3rd-Level-Support@bs-card-service.com";
        private string Passwort = "martin+";

        public static IEnumerable<TestCaseData> LoginDataCSV()
        {
            return CSVDataReader.ReadCSV(csvFilePath);
        }

        [Category("csv")]
        [Test, TestCaseSource("LoginDataCSV")]
        public void UserTestDataParamCSVData(String anrede, String titel, String vorname, String nachname, String sprache, String benutzername, String emailAdresse, String passwort)
        {
            Assert.That(anrede, Is.EqualTo(Anrede));
            Assert.That(titel, Is.EqualTo(Titel));
            Assert.That(vorname, Is.EqualTo(Vorname));
            Assert.That(nachname, Is.EqualTo(Nachname));
            Assert.That(sprache, Is.EqualTo(Sprache));
            Assert.That(benutzername, Is.EqualTo(Benutzername));
            Assert.That(emailAdresse, Is.EquivalentTo(EMailAdresse));
            Assert.That(passwort, Is.EquivalentTo(Passwort));

            anrede = null!;
            titel = null!;
            vorname = null!;
            nachname = null!;
            sprache = null!;
            benutzername = null!;
            emailAdresse = null!;
            passwort = null!;
        }
    }
}