// Time is followed in 24hr format
let time = 12;
let fare = 24000;

if(time >= 6 && time <= 9) {
    let newfare = ((fare * 10)/100) + fare;
    console.log(newfare);
} else if(time > 9 && time <= 17) {
    let newfare = ((fare * 20)/100) + fare;
    console.log(newfare);
}else if(time > 17 && time <= 23) {
    let newfare = ((fare * 7)/100) + fare;
    console.log(newfare);
}
else if(time > 23 && time < 6) 
{
    let newfare = ((fare * 5)/100) + fare;
    console.log(newfare);
}
