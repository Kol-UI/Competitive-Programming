namespace CompetitiveProgramming.Algorithms
{
    #nullable disable
    class Tree
    {
        public static void Sample()
        {
            // Create Tree
            TreeNode root = new TreeNode(3);
            TreeNode node2 = new TreeNode(9);
            TreeNode node3 = new TreeNode(20);
            TreeNode node4 = new TreeNode(15);
            TreeNode node5 = new TreeNode(7);

            // Link Nodes
            root.left = node2;
            root.right = node3;
            node3.left = node4;
            node3.right = node5;

            // Print Tree
            Console.WriteLine("\nLevel Order:");
            PrintLevelOrder(root);

            Console.WriteLine("\nPre-order:");
            Preorder(root);

            Console.WriteLine("\nIn-order:");
            Inorder(root);

            Console.WriteLine("\nPost-order:");
            Postorder(root);
        }

        // Level Order
        public static void PrintLevelOrder(TreeNode root)
        {
            if (root == null)
                return;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int count = queue.Count;

                for (int i = 0; i < count; i++)
                {
                    TreeNode node = queue.Dequeue();
                    Console.Write(node.val + " ");

                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }

                Console.WriteLine();
            }
        }

        // Pre-order
        public static void Preorder(TreeNode root)
        {
            if (root == null)
                return;

            Console.Write(root.val + " "); 
            Preorder(root.left);
            Preorder(root.right);
        }

        // In-order
        public static void Inorder(TreeNode root)
        {
            if (root == null)
                return;

            Inorder(root.left);
            Console.Write(root.val + " "); 
            Inorder(root.right);
        }

        // Post-order
        public static void Postorder(TreeNode root)
        {
            if (root == null)
                return;

            Postorder(root.left);
            Postorder(root.right);
            Console.Write(root.val + " "); 
        }
    }
    #nullable enable
}