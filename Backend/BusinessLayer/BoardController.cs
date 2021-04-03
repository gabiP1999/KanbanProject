using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroSE.Kanban.Backend.BusinessLayer
{
    class BoardController
    {
        private Dictionary<string , Board> BoardList;
        public BoardController()
        {
            BoardList = new Dictionary<string, Board>();
        }
        public bool addBoard(Board board) {
            if (BoardList.ContainsKey(board.getId())) throw new Exception("A board with the same ID exists");
            BoardList.Add(board.getId(), board);
            return true;
        }
        public Board removeBoard(string id) {
            if (!BoardList.ContainsKey(id)) throw new Exception("board does not exist");
            Board tmp = BoardList[id];
            BoardList.Remove(id);
            return tmp;
        
        }
        public Board getBoard(string id) {
            if (!BoardList.ContainsKey(id)) throw new Exception("board does not exist");
            return BoardList[id];
        }

    }
}
