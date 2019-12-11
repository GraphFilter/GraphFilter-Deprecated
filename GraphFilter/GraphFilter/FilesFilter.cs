using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphFilter
{
    public class FilesFilter
    {
        public Stream fileG6In { get; private set; }
        public Stream fileG6Out { get; private set; }

        public FilesFilter(Stream fileIn, Stream fileOut)
        {
            this.fileG6In = fileIn;
            this.fileG6Out = fileOut;

        }

        public void Run()
        {
            /*string condition1 = "R????A?O@?A?A?@??OCA?[??L?AC?_";
            double numberOfGraphsIn = 0;
            double numberOfGraphsOut = 0;
            int indiceProgressBar = 1;
            using (StreamReader stReaderIn = new StreamReader(fileG6In))
            {
                using (StreamWriter stWriterOut = new StreamWriter(textOutPath.Text))
                {
                    String g6Line = stReaderIn.ReadLine();
                    while (g6Line != null)
                    {
                        
                        progressBar.Value = indiceProgressBar;
                        if (condition1.Contains("R????A?O@?A?A?@??OCA?[??L?AC?_"))
                        {
                            numberOfGraphsOut++;
                            stWriterOut.WriteLine(g6Line);
                        }
                        numberOfGraphsIn++;
                        g6Line = stReaderIn.ReadLine();
                        indiceProgressBar++;
                    }
                }
            }
            double percentual = Math.Round((numberOfGraphsOut / numberOfGraphsIn) * 100, 2);
            MessageBox.Show("Busca realizada com sucesso! \nO percentual de grafos escolhidos é: " + percentual + " %" + "\nO número de grafos escolhidos foi de: " + numberOfGraphsOut + "\nO número total de grafos que foram lidos foi de: " + numberOfGraphsIn + ".");
        */
    }

}
}
