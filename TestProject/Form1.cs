
using System;
using System.Linq;
using Common.Logging;
using System.Windows.Forms;
using TestProject.Dao;

namespace TestProject
{
    public partial class Form1 : Form
    {
        private readonly ILog _log;

        private ProcessDao processDao = new ProcessDao();

        public Form1()
        {
            InitializeComponent();

            _log = LogManager.GetLogger(GetType());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            int count;
            _log.Info("Begin process connect to Database.");

            try
            {
                _log.Info("Trying connect to database");              

                var response = processDao.GetEmpleados();
                
                if (response.Count != 0)
                {
                    _log.Info("List employees aren't empty");

                    for (count = 0; count <= response.Count - 1; count++)
                    {
                        this.richTxtBoxEmpleados.AppendText(response[count].Id + " - " + response[count].Nombre + " - " + response[count].cargo + " - " + response[count].profesion + "\n");
                        _log.Info($"Adding employee : {count + 1}.");
                    }

                    this.lblResponse.Text = "Employees loaded :" + count;
                }
                else
                {
                    _log.Warn("Wasn't possible make a query");
                    this.lblResponse.Text = "Wasn't possible make a query";
                }
            }
            catch (Exception ex)
            {
                _log.Error($"Error: {ex.Message}");
                throw;
            }


            _log.Info("End process connect to Database.");
            _log.Info("********************************************************************************************************************");
        }
    }
}
