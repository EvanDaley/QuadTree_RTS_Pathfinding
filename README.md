# Quad Tree Experimentation

Problem: Calculating distances between things is expensive. Lets say we have 10 towers (n) and 1000 zombies (m) charging toward them. For turrets to know which zombies are closest, we might calculate the distances between all turrets and all zombies, but thats exremely expensive (m*n distance calculations).

Approach: This project demonstrates the use of a Quad Tree to simplify the detection. The Quad Tree figures out which targets are "roughly in range" of a tower, and once we have that list, we can do the more expensive vector distance calculations to determine which target is closest to the tower.

<video src="20231120-0040-53.2402874.mp4" controls title="Title"></video>

![Quad Tree](image-1.png)

- The grey squares will pathfind to random positions around the map
- As they move around, the white grid will update, displaying the state of the quad tree
- Red numbers represent how many objects are in a given quad
- The teal towers are looking for enemies, and have a red border for the area they consider
- Green numbers represent the number of objects "in range" of a tower
- Red squares represent the range a tower considers
- Within each red boundary, we can know in constant time how many enemies are present. 
- Within that set of enemies, we can do exact distance calculations to know which enemy is closest to a tower