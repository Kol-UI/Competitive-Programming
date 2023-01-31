class Solution {
    fun isReachable(targetX: Int, targetY: Int): Boolean {
        tailrec fun gcd(x: Int, y: Int): Int = if (x == 0 || y == 0) x + y else gcd(y % x, x)
        return gcd(targetX, targetY).let { it and it - 1 } == 0
    }
}