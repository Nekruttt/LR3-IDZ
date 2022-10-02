using ЛР3_ИДЗ_LIB;
namespace ЛР3_ИДЗ
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(3, 3);
            Matrix.PrintMatrix(matrix);
            Matrix.GetSrArif(matrix);
            Matrix.PrintResultMatrix(matrix);
        }
    }
}