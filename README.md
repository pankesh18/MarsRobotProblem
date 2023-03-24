# Mars Robot Problem

Steps:
1. Take plateau size input
2. Take robot navigation instrcution
3. navigate robot left/right/forward for each instruction
4. For left or right, change direction considering the current facing direction
5. For forward, change x-axis or y-axis position based on the current facing direction
6. print final current position and facing direction


Assumptions:
1. Starting position is 1,1
2. starting facing direction is north
3. 0,0 position doesnt exists
4. if robot reaches to limit of plateau size, move forward command to be ignored
5. Inputs are all valid


Future Scope and Improvements:
1. We can validate the inputs for plateau size
2. We can validate the inputs for navigation size
3. Custom exception handling could be done if assumptions were not in place

