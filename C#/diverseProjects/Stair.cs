using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diverseProjects
{
    internal class Stair
    {
        private int _lines;
        private int _columns;
        private char[,] _stair;

        public Stair(int lines, int columns) {
            this._lines = lines;
            this._columns = columns;
            this._stair = new char[lines, columns];
        }

        public int GetColumns() {
            return _columns;
        }

        public int GetLines() {
            return this._lines;
        }

        public int GetReason() {
            return (this._columns / this._lines);
        }

        public char[,] GetStair() {
            return this._stair;
        }

        public void SetColumns(int columns) {
            this._columns = columns;
        }

        public void SetLines(int lines) {
            this._lines = lines;
        }

        public void SetStairElement(int x, int y, char value) {
            this._stair[x, y] = value;
        }

        public void UpdateStairSize() {
            this._stair = new char[this._lines, this._columns];
        }

    }


    internal class StairBuilder
    {

        public static void BuildStair(Stair stair) {
            for (int i = 0; i < stair.GetLines(); i++) {
                for (int j = 0; j < i * stair.GetReason(); j++) {
                    char ch = (j < (i * stair.GetReason()) - stair.GetReason()) ? 'x' : '¬';
                    stair.SetStairElement(i, j, ch);
                }
            }
        }

        public static void ShowStair(Stair stair) {
            for (int i = 0; i < stair.GetLines(); i++) {
                for (int j = 0; j < stair.GetColumns(); j++) {
                    Console.Write(stair.GetStair()[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
