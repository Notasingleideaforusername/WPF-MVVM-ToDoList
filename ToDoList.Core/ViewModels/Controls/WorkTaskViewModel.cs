﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Core.Base;

namespace ToDoList.Core.ViewModels.Controls
{
    public class WorkTaskViewModel :BaseViewModel
    {
        public bool IsSelected { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
