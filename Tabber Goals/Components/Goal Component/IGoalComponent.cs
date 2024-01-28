using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabber_Goals.Components.Goal_Component
{
    internal interface IGoalComponent
    {
        string Title { get; set; }
        int Progress { get; set; } 
        DateTime TargetDate { get; set; }
    }
}
