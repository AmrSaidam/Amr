using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStock.Entity
{
    class MessageSh
    {
        private int ID;
        private string Messages;
        private DateTime Date;
        private Color Colors;

        public int IDs
        {
            get 
            {
                return ID;
            }
            set
            
            {
                this.ID = value;
            }
        }

        public string Messagess
        {
            get
            {
                return this.Messages;
            }
            set
            {
                this.Messages = value;
            }
        }

        public DateTime Dates
        {
            get
            {
                return Date;
            }
            set
            {
                this.Date = value;
            }
        }

        public Color Colorss
        {
            get
            {
                return Colors;
            }
            set
            {
                this.Colors = value;
            }
        }
    }
}
