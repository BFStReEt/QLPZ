using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlyquanan.DTO
{
    class Category
    {

        private int iD;

        private string name;

        public string imageCategory;

        public Category(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
        }
        public Category(int iD, string name, string imageCategory)
        {
            this.ID = iD;
            this.Name = name;
            this.ImageCategory = imageCategory;
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string ImageCategory
        {
            get { return imageCategory; }
            set { imageCategory = value; }
        }
    }
}
