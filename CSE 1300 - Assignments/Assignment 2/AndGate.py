import turtle
S = turtle.getscreen()

AND = turtle.Turtle()
AND.pen(pensize=10, speed=2.5)
AND.shape("circle")


def DrawHorizontalLine(X, Y, LENGTH):
    AND.up()
    AND.goto(X,Y)
    AND.down()
    AND.forward(LENGTH)
    AND.up()
    AND.goto(0,0)

DrawHorizontalLine(100,0, 100)
DrawHorizontalLine(-125,50, 50)
DrawHorizontalLine(-125,-50, 50)
DrawHorizontalLine(-75, 100,75)
DrawHorizontalLine(-75,-100,75)

AND.goto(0,-100)
AND.down()
AND.circle(100,180)
AND.up()
AND.goto(-75, 100)
AND.down()
AND.goto(-75,-100)