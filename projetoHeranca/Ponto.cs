using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHeranca
{
    public class Ponto{
        private string descricao; private int x; private int y;
        public Ponto(){
            this.descricao = "p"; this.x = 5; this.y = 5;
        }
        public Ponto(string descricao): this(){            
            this.descricao = descricao;            
        }
        public Ponto(string descricao, int x, int y): this(descricao){
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get => x;
            set => x = value;
        } 
        public int Y
        {
            get => y;
            set => y = value;
        }

        public String Descricao
        {
            get => descricao;
            set => descricao = value;
        }

        public void incrementarCoordenadas(int deltaX, int deltaY)
        {
            x = x + deltaX;
            y = y + deltaY;
        }

        public void imprimirCoordenadas()
        {
            // imprime as coordenadas x e y
            Console.WriteLine("(x, y)=" + "(" + x + ", " + y + ")");
        }

        public void zerarCoordenadas()
        {
            x = 0;
            y = 0;
        }

        public override string ToString()
        {
            return "Ponto{" + "descricao=" + descricao + ", x=" + x + ", y=" + y + '}';
        }

    }
}
