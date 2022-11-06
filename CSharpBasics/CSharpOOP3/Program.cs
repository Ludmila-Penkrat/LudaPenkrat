using CSharpOOP3;
using System;

Ball ball = new Ball(name: "Football ball", radius: 10);
ball.GetVolume();
ball.ShapeInfo();

Pyramid piramid = new Pyramid(name: "The Piramida of Cheops", height:138, baseArea: 53_000);
piramid.GetVolume();
piramid.ShapeInfo();

Cylinder cylinder = new Cylinder(name: "Case Cylinder", height:  68, radius: 4.5);
cylinder.GetVolume();
cylinder.ShapeInfo();

Student student = new Student(name: "Pavel", surname: "Pavlov", age: 21);
student.StudentInfo();