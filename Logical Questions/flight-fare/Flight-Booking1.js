// Time is followed in 24hr format
let hour = prompt("enter hour in 24hr format");
let minute = prompt("enter time in minutes");
let fare = 24000;

if(hour >= 6 &&  hour <= 9 && minute >= 0 && minute <= 59) {
    let newfare = ((fare * 10)/100) + fare;
    console.log(newfare);
} else if(hour >= 9 && hour <= 17 && minute >= 0 && minute <= 59 ) {
    let newfare = ((fare * 20)/100) + fare;
    console.log(newfare);
}else if(hour > 17 && hour <= 23 && minute >= 0 && minute <= 59) {
    let newfare = ((fare * 7)/100) + fare;
    console.log(newfare);
}
else if(hour > 23 && hour < 6 && minute >= 0 && minute <= 59) 
{
    let newfare = ((fare * 5)/100) + fare;
    console.log(newfare);
}
