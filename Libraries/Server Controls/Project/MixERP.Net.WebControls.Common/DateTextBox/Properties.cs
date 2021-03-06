﻿/********************************************************************************
Copyright (C) Binod Nepal, Mix Open Foundation (http://mixof.org).

This file is part of MixERP.

MixERP is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

MixERP is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with MixERP.  If not, see <http://www.gnu.org/licenses/>.
***********************************************************************************/

using MixERP.Net.Common.Models.Core;

/********************************************************************************
Copyright (C) Binod Nepal, Mix Open Foundation (http://mixof.org).

This file is part of MixERP.

MixERP is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

MixERP is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with MixERP.  If not, see <http://www.gnu.org/licenses/>.
***********************************************************************************/

using System;
using System.Web.UI.WebControls;

namespace MixERP.Net.WebControls.Common
{
    public partial class DateTextBox : CompositeControl
    {
        private bool enableValidation;

        private Frequency mode;

        public override string CssClass
        {
            get
            {
                this.EnsureChildControls();
                return this.textBox.CssClass;
            }
            set
            {
                this.EnsureChildControls();
                this.textBox.CssClass = value;
            }
        }

        public bool Disabled
        {
            get
            {
                this.EnsureChildControls();
                return !this.textBox.Enabled;
            }
            set
            {
                this.EnsureChildControls();
                this.textBox.Enabled = !value;
            }
        }

        public bool EnableValidation
        {
            get
            {
                this.EnsureChildControls();
                return this.enableValidation;
            }
            set
            {
                this.EnsureChildControls();
                this.enableValidation = value;
            }
        }

        public override string ID { get; set; }

        public DateTime? MaxDate { get; set; }

        public DateTime? MinDate { get; set; }

        public Frequency Mode
        {
            get
            {
                this.EnsureChildControls();
                return this.mode;
            }
            set
            {
                this.EnsureChildControls();
                this.mode = value;
                this.InitializeDate(this.mode);
            }
        }

        public bool Required { get; set; }

        public string Text
        {
            get
            {
                this.EnsureChildControls();
                return this.textBox.Text;
            }
            set
            {
                this.EnsureChildControls();
                this.textBox.Text = value;
            }
        }

        public string ValidatorCssClass { get; set; }

        public override Unit Width
        {
            get
            {
                this.EnsureChildControls();
                return this.textBox.Width;
            }
            set
            {
                this.EnsureChildControls();
                this.textBox.Width = value;
            }
        }
    }
}