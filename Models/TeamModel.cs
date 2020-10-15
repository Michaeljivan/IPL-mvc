using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IPL.Models
{
    public class TeamModel
    {
        //Team 1
        [Display(Name = "Team 1")]
        public string TeamName1 { get; set; }
        public int Runs1 { get; set; }
        public int Wickets1 { get; set; }
        public decimal Overs1 { get; set; }
    
        //Team 2
        [Display(Name = "Team Name 2")]
        public string TeamName2 { get; set; }
        public int Runs2 { get; set; }
        public int Wickets2 { get; set; }
        public decimal Overs2 { get; set; }
    }
}
