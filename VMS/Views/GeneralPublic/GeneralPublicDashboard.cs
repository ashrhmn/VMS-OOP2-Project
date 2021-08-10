using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VMS.Entity;
using VMS.Repository;

namespace VMS.Views.GeneralPublic
{
    public partial class GeneralPublicDashboard : Form
    {
        private readonly UserDetailRepo _udr;
        public GeneralPublicDashboard(string username)
        {
            InitializeComponent();
            _udr = new UserDetailRepo();
            RefreshData(username);
        }

        void RefreshData(string username)
        {
            UserDetail userDetail = _udr.GetUserDetail(username);
            if (userDetail != null)
            {
                textBoxUsername.Text = userDetail.UserName;
                textBoxName.Text = userDetail.Name;
                textBoxFathername.Text = userDetail.FatherName;
                textBoxMotherName.Text = userDetail.MotherName;
                textBoxGender.Text = userDetail.Gender;
                textBoxAddress.Text = userDetail.Address;
                textBoxDateOfBirth.Text = userDetail.DateOfBirth.ToString();
                textBoxNid.Text = userDetail.NID;
            }

        }
    }
}
