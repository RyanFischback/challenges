class Solution(object):
    def isValid(self, s):
        """
        :type s: str
        :rtype: bool
        """
        stack = []
        opening_brackets = ['(', '{', '[']
        closing_brackets = [')', '}', ']']
        bracket_pairs = {'(': ')', '{': '}', '[': ']'}

        for char in s:
            if char in opening_brackets:
                stack.append(char)
            elif char in closing_brackets:
                if len(stack) == 0:
                    return False
                top = stack.pop()
                if bracket_pairs[top] != char:
                    return False
        
        return len(stack) == 0


