﻿using DataAceesLayer.Abstract;
using DataAceesLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAceesLayer.EntityFramework
{
    public class EfPacketRepositories : GenericRepositories<Packet>, IPacketDal
    {
    }
}
