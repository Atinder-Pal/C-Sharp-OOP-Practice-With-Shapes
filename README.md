# c-review-oop-practice---shape-class-Atinder-Pal
c-review-oop-practice---shape-class-Atinder-Pal created by GitHub Classroom

**Purpose:** This practice is designed to get familiarization with inheritance, polymorphism, encapsulation and abstraction. </br>
**Author:** Atinder Pal

**Requirements:**
1. “.Shapes” namespace extension created.:
      * Create a folder called “Shapes”.
      * All classes in “Shapes” should have “.Shapes” as part of their namespace.
2. Abstract “Shape” class created in the “Shapes” folder.
    * Properties, public getters only that must be overridden and provided functionality by derived classes:
         * “Area”
         * “Perimeter”
    * Traditional Properties:
         * “Colour”
         * String for the name of the colour is sufficient.
    * Methods:
         * Default and greedy constructors that are overridden and provided functionality by derived classes. 
         * “Colour” should not be explicitly set in the derived classes, the base constructor should be called.
3. “Circle” class derived from “Shape” created in the “Shapes” folder.
          <p> “Perimeter” is equivalent to a circumference for “Circle”.</p>
    * Properties:
         * “Radius”
         * “Diameter”
         * Public getter that derives its value from “Radius”.
4. “Rectangle” class derived from “Shape” created in the “Shapes” folder.
    * Properties:
         * “Length”
         * “Width”
5. “Triangle” class derived from “Shape” created in the “Shapes” folder.
    * Represents an equilateral or isosceles triangle, not a scalene triangle.
    * Properties:
         * “Base”
         * “Height”
6. “Drawing” class created in the root (not in “Shapes”):
    * Properties:
         * “Shapes” (private getter and setter)
         * Polymorphic list of “Shape”.
         * “SpaceCovered” (public getter only)
          * Total area of the contents of “Shapes”.
          * “LinesDrawn” (public getter only).
          * The total perimeter/circumference of the contents of “Shapes”.
    * Methods:
        * “Draw(Shape)” 
        * Accepts a polymorphic “Shape” argument and adds it to the “Shapes” list.
        * A ToString() override, which will output “A drawing consisting of X shapes.” where X is the number of items in “Shapes”.
        * A default constructor that will initialize “Shapes”.
7. Add comments to specify at least one area of the program that demonstrates each pillar of OOP 


**Link To Trello Board:** https://trello.com/b/5B7eD8aS/c-review-oop-practice-shape-class
