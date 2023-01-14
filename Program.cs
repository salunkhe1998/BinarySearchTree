using System.Security.Cryptography.X509Certificates;

namespace BinarySearchTree
{
    class Program
    {
        public static void Main(string[] args)
        {
            Binarytree bn = new Binarytree();
            bn.Add(30);
            bn.Add(40);
            bn.Add(50);
            bn.Add(60);
            bn.Add(80);
            Console.WriteLine("After Preorder Result Will be: ");
            bn.TravesrePreorder(bn.root);
            Console.WriteLine("After Postorder Result Will be: ");
            bn.TravesrePostorder(bn.root);
            Console.WriteLine("After Inorder Result Will be: ");
            bn.TravesreInorder(bn.root);
        }

    }
}