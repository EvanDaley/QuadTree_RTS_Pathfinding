# Quad Tree Experimentation

Calculating distances between things is expensive.

Lets say we have 10 turret (n) and 1000 zombies (m) rushing in.

For turrets to know which zombies are closest, we might calculate the distances between all turrets and all zombies, but thats exremely expensive (m*n)

This project demonstrates the use of a Quad Tree to simplify the detection. 

By only considering distance calculations within a limited bounds of each tower, we simplify the computation dramatically.

<video src="20231120-0040-53.2402874.mp4" controls title="Title"></video>

- Red squares represent the bounds of a turret 
- The numbers next to the turret represent how many enemies they can "see"
- Within that boundary, we can efficiently calculate exact distances to enemies, and target the closest, etc.