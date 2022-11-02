using CSharpOOP3;

Ball ball = new Ball(name: "Football ball", radius: 10);
ball.GetValue();
ball.ShapeInfo();

Pyramid piramid = new Pyramid(name: "The Piramida of Cheops", height:138, baseArea: 53_000);
piramid.GetValue();
piramid.ShapeInfo();

Cylinder cylinder = new Cylinder(name: "Case Cylinder", height:  68, radius: 4.5);
cylinder.GetValue();
cylinder.ShapeInfo();

Student student = new Student(name: "Pavel", surname: "Pavlov", age: 21);
student.StudentInfo();