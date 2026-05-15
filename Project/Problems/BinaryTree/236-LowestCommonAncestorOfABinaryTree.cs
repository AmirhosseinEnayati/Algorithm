namespace Project.Problems.BinaryTree;

public class LowestCommonAncestorOfABinaryTree
{
    /*
     HINT:
      If one side does not contain p or q, then the other side must contains it in its subtree.
      For example, if the left side returns null but the right side returns a non-null node, it means the right side contains both of them.
      Once one of them is found, the other one must be located somewhere in its descendants.
     */
    public TreeNode? LowestCommonAncestor(TreeNode? root, TreeNode p, TreeNode q)
    {
        if (root is null)
            return null;

        if (root.val == p.val || root.val == q.val)
        {
            return root;
        }

        var node1 = LowestCommonAncestor(root.left, p, q);
        var node2 = LowestCommonAncestor(root.right, p, q);

        if (node1 is not null && node2 is not null)
        {
            return root;
        }

        return node1 ?? node2;
    }
}