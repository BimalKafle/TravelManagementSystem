﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.CoreLayer.DTO.District
{
    public class DistrictInsertDTO
    {
        public string Name { get; set; }
        public DistrictInsertDTO(string _name)
        {
            this.Name= _name;
        }
    }
}