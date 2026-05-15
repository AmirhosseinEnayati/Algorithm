using Project.Problems.BinaryTree;

Main();

static void Main()
{

    var x = new LowestCommonAncestorOfABinaryTree().LowestCommonAncestor(
         new TreeNode(3,
         new TreeNode(5,
         new TreeNode(6, null, null),
         new TreeNode(2,
         new TreeNode(7, null, null),
         new TreeNode(4, null, null))),
         new TreeNode(1,
         new TreeNode(0, null, null),
         new TreeNode(8, null, null))),

        new TreeNode(5, null, null),
        new TreeNode(1, null, null)
        );


    int x2 = 0;
}
