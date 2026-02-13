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
                    var query = _context.Equipments.Select(e => new
                    {
                        e.Id,
                        e.SerialNumber,
                        e.Model,
                        Category = e.Category.ToString(),
                        Status = e.Status.ToString(),
                        Condition = e.EquipmentCondition.ToString()
                    }).ToList();
                    dataGridView1.DataSource = query;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var _context = new AppDbContext())
                {
                    if (string.IsNullOrWhiteSpace(txtSerialNum.Text) || string.IsNullOrWhiteSpace(txtModels.Text) ||
                        comboCategory.SelectedItem == null || comboLoanStatus.SelectedItem == null || comboCondition.SelectedItem == null)
                    {
                        MessageBox.Show("Please fill in all fields.");
                        return;
                    }
                    var equipment = new Equipment
                    {
                        SerialNumber = txtSerialNum.Text,
                        Model = txtModels.Text,
                        Category = (Equipment.Categories)Enum.Parse(typeof(Equipment.Categories), comboCategory.SelectedItem.ToString()),
                        Status = (Equipment.LoanStatus)Enum.Parse(typeof(Equipment.LoanStatus), comboLoanStatus.SelectedItem.ToString()),
                        EquipmentCondition = (Equipment.Condition)Enum.Parse(typeof(Equipment.Condition), comboCondition.SelectedItem.ToString())
                    };
                    _context.Equipments.Add(equipment);
                    _context.SaveChanges();
                    MessageBox.Show("Equipment saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    int equipmentId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                    using (var _context = new AppDbContext())
                    {
                        var equipment = _context.Equipments.Find(equipmentId);
                        if (equipment != null)
                        {
                            _context.Equipments.Remove(equipment);
                            _context.SaveChanges();
                            MessageBox.Show("Equipment deleted successfully!");
                            btnDisplay_Click(sender, e); // Refresh the data grid
                        }
                        else
                        {
                            MessageBox.Show("Equipment not found.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select an equipment to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    int equipmentId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                    using (var _context = new AppDbContext())
                    {
                        var equipment = _context.Equipments.Find(equipmentId);
                        if (equipment != null)
                        {
                            equipment.SerialNumber = txtSerialNum.Text;
                            equipment.Model = txtModels.Text;
                            equipment.Category = (Equipment.Categories)Enum.Parse(typeof(Equipment.Categories), comboCategory.SelectedItem.ToString());
                            equipment.Status = (Equipment.LoanStatus)Enum.Parse(typeof(Equipment.LoanStatus), comboLoanStatus.SelectedItem.ToString());
                            equipment.EquipmentCondition = (Equipment.Condition)Enum.Parse(typeof(Equipment.Condition), comboCondition.SelectedItem.ToString());
                            _context.SaveChanges();
                            MessageBox.Show("Equipment updated successfully!");
                            btnDisplay_Click(sender, e); // Refresh the data grid
                        }
                        else
                        {
                            MessageBox.Show("Equipment not found.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select an equipment to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
