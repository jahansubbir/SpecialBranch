using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SpecialBranch.Gateway;
using SpecialBranch.Models;

namespace SpecialBranch.BLL
{
    public class RpoManager
    {
        RpoGateway rpoGateway=new RpoGateway();

        public string SaveRpo(Rpo rpo)
        {
            if (rpoGateway.SaveRpo(rpo) > 0)
            {
                return "Success";
            }
            else
            {
                return "Failed";
            }
        }

        public List<Rpo> GetRpos()
        {
            return rpoGateway.GetRpos();
        }

        public Rpo Details(int? id)
        {
            return rpoGateway.Details(id);
        }

        public string Edit(Rpo rpo)
        {
            if (rpoGateway.Edit(rpo)>0)
            {
                return "Edited successfully";
            }
            else
            {
                return "Failed";
            }
        }

        public string Delete(Rpo rpo)
        {
            if (rpoGateway.Delete(rpo)>0)
            {
                return "Deleted";
            }
            else
            {
               return "Failed";
            }
        }
    }
}