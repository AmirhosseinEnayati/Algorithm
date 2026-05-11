Main();

static void Main()
{
    new Project.Problems.BinaryTree.LeafSimilarTrees().LeafSimilar(
        new Project.Problems.BinaryTree.TreeNode(3,
          new Project.Problems.BinaryTree.TreeNode(5, 
            new Project.Problems.BinaryTree.TreeNode(6,null,null), 
            new Project.Problems.BinaryTree.TreeNode(2,
               new Project.Problems.BinaryTree.TreeNode(7,null,null),
               new Project.Problems.BinaryTree.TreeNode(4,null,null)
               )),
          new Project.Problems.BinaryTree.TreeNode(1, 
            new Project.Problems.BinaryTree.TreeNode(9,null,null), 
            new Project.Problems.BinaryTree.TreeNode(8,null,null)))
        ,
    new Project.Problems.BinaryTree.TreeNode(3,
        new Project.Problems.BinaryTree.TreeNode(5, 
            new Project.Problems.BinaryTree.TreeNode(6,null,null), 
            new Project.Problems.BinaryTree.TreeNode(7,null,null)),
        new Project.Problems.BinaryTree.TreeNode(1, 
            new Project.Problems.BinaryTree.TreeNode(4,null,null), 
            new Project.Problems.BinaryTree.TreeNode(2,
              new Project.Problems.BinaryTree.TreeNode(9,null,null),
              new Project.Problems.BinaryTree.TreeNode(8,null,null))))
    );
}
