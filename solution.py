class Solution(object):
    def hammingWeight(self, n):
        """
        :type n: int
        :rtype: int
        """

        s = bin(n)
        sum = 0
        for i in range(2, len(s)):
            if(s[i] == "1"):
                sum = sum + 1

        return(sum)
