clear all
clc
f=@(x,y)x*x-y;
x0=input('\n Enter initial value of x i.e. x0: '); 
y0=input('\n Enter initial value of y i.e. y0: '); 
xn=input('\n Enter the final value of x: ');                               
h=input('\n Enter the step length h: '); 
 fprintf('\n x        y ');
while x0<=xn
    fprintf('\n%4.3f  %4.3f ',x0,y0);
    y1=y0+h*f(x0,y0);
    x1=x0+h;
    x0=x1;
    y0=y1;  
end