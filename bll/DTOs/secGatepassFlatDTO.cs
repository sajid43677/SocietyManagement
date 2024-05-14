using dal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll.DTOs
{
    public class secGatepassFlatDTO : manFlatDTO
    {
        public List<secGatePassDTO> gatepasses {  get; set; }

        public secGatepassFlatDTO()
        {
            gatepasses = new List<secGatePassDTO>();
        }
    }
}
