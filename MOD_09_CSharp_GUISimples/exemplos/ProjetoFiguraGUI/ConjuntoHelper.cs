using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using model;

namespace controller
{
    /**
     * Classe ConjuntoHelper.
    */
    public class ConjuntoHelper
    {
        private static ConjuntoHelper instance;

        private List<FiguraVO> listaObjetos;

        /**
         * Construtor privado.
        */
        private ConjuntoHelper()
        {
            listaObjetos = new List<FiguraVO>();
        }

        /**
         * getInstance do padrão singleton.
         * @return instância do singleton.
        */
        public static ConjuntoHelper getInstance()
        {
            if (instance == null)
            {
                instance = new ConjuntoHelper();
            }
            return instance;
        }

        /**
         * Adiciona um novo objeto do tipo FigutaVO no helper.
         * @param objeto do tipo FiguraVO a ser adicionado no singleton.
         * @return número de objetos adicionados.
        */
        public int adicionar(FiguraVO figuraVO)
        {
            listaObjetos.Add(figuraVO);
            return 1;
        }

        /**
         * Lista todos os objetos na saída padrão.
         * @param void.
         * @return void.
        */
        public void listar()
        {
            FiguraVO p = null;
            Console.WriteLine("Início listar...");
            for (int i = 0; i < listaObjetos.Count; i++)
            {
                p = (FiguraVO)listaObjetos[i];
                Console.WriteLine(p);
            }
            Console.WriteLine("Fim listar...");
        }

        /**
         * Exclui um objeto do tipo FiguraVO.
         * @param: objeto do tipo FiguraVO a ser excluído.
         * @return void.
        */
        public void excluir(FiguraVO figuraVO)
        {
            // exclui um objeto
        }

        /**
         * Retorna todos os objetos do tipo FiguraVO.
         * @param: void.
         * @return string resultado da concatenção do métodos ToString de todos os objetos.
        */
        public string getTodos()
        {
            
            string todos = "";
            FiguraVO p = null;
            if (listaObjetos.Count > 0)
            {
                for (int i = 0; i < listaObjetos.Count; i++)
                {
                    p = (FiguraVO) listaObjetos[i];
                    todos = todos + p.ToString();
                }
            }
            else
            {
                todos = "Não há objetos instanciados.";
            }
            
            return todos;
            
        }
    }
}
