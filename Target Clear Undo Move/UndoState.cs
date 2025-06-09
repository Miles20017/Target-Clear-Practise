using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target_Clear_Undo_Move
{
    public class UndoState
    {
        private List<int> NumberAllowed = new List<int>();
        private List<int> Targets = new List<int>();
        private int Score;

        public UndoState(List<int> NumberAllowed, List<int> Targets, int Score)
        {
            this.NumberAllowed.AddRange(NumberAllowed);
            this.Targets.AddRange(Targets);
            this.Score = Score;
        }

        public List<int> GetNumbersAllowed()
        {
            return NumberAllowed;
        }

        public List<int> GetTargets()
        {
            return Targets;
        }

        public int GetScore()
        {
            return Score;
        }

        public void Restore(List<int> NumberAllowed, List<int> Targets, int Score)
        {
            NumberAllowed = this.NumberAllowed;
            Targets = this.Targets;
            Score = this.Score;
        }
    }
}
