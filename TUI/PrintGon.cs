using System;
using System.Collections.Generic;

namespace Konsol
{
    public class PrintGon
    {
        private List<Int32> nGon;
        private int yPos = 0;
        private int xPos = 1;
        private string getY(){
            string retval = "";
            for(int i = 0; i < this.yPos; i++){
                retval += "\n";
            }
            return retval;
        }
        private string getX(){
            string retval = "";
            for(int i = 0; i  < this.xPos; i++){
                retval += " ";
            }
            return retval;
        }
        private List<List<Int32>> splitList(List<Int32> list0){
            List<List<Int32>> retval = new List<List<Int32>>();
            List<Int32> left = new List<Int32>();
            List<Int32> right = new List<Int32>();
            int list0L = list0.Count;
            int midWay = list0L / 2;
            bool even = list0L % 2 == 0;
            for(int i = 0; i < list0L; i++){
                if(i < midWay){
                    right.Add(list0[i]);
                } else {
                    left.Add(list0[i]);
                }
            }
            left.Reverse();
            retval.Add(left);
            retval.Add(right);
            return retval;
        }
        private int Ceil(double d){
            if(d <= 0){
                return 0;
            }
            return 1;
        }
        private List<string> circlePrint(int n){
            double rad = System.Convert.ToDouble(n) * (Math.PI / 2);
            int spaces = this.Ceil(Math.Sin(rad));
            List<string> retList = new List<string>();
            string retSpaces = "";
            string retIndent = "";
            for(int i = 0; i <= spaces * 4 + 1; i++){
                retSpaces += " ";
            }
            for(int j = 0; j <= 2 - (spaces * 2 + 1); j++){
                retIndent += " ";
            }
            retList.Add(retIndent);
            retList.Add(retSpaces);
            return retList;
        }
        public PrintGon(List<Int32> l0){
            this.nGon = l0;
        }
        public void SetGon(List<Int32> l0){
            this.nGon = l0;
        }
        public override string ToString(){
            List<List<Int32>> vertices = this.splitList(this.nGon);
            List<string> circleSpec;
            string retval = "";
            string spaces;
            string indent;
            for(int i = 0; i < vertices[0].Count; i++){
                circleSpec = this.circlePrint(i);
                indent = circleSpec[0];
                spaces = circleSpec[1];
                retval += indent + vertices[0][i].ToString() + spaces + vertices[1][i].ToString() + "\n";
            }
            return retval;
        }
    }
}

