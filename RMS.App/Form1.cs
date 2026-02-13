using RMS.Infrastructure.Data;
using Microsoft.SqlServer;
using System;
using Microsoft.EntityFrameworkCore;
using RMS.Domain.Models;

namespace RMS.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                using (var _context = new AppDbContext())
                {
                    var query = _context.Equipments
                        .Where(e => e.EquipmentType == "Laptop")
                        .Select(e => new { e.Name, e.EquipmentType });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
