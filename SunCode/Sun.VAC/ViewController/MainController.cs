﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sun.Zone;

namespace Sun.VAC.Pagelet
{
    public class MainController
    {
        [Action]
        [PageUrl(Url = "/suncms/main.aspx")]
        public static PageResult LoadModel()
        {
            MainModel model = new MainModel();

            Sun.Entity.SysMenu menu = new Entity.SysMenu() { Name = "alex2222222" };
            model.Menu = menu;

            string url = "/suncms/main.aspx";

            return new PageResult(url, model);
        }

    }
}
