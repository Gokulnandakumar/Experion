const passengers = ['Athul', 'Ramesh', 'Bibin', 'Deepak', 'Hari', 'Hari', 'Ramu', 'Rajesh', 'Sojan', 'Ashwin', 'Ashwin', 'Karnan'];

for (let i = 0; i < passengers.length; i++) {
    for (let j = i+1; j < passengers.length; j++) {
        if(passengers[i] === passengers[j]) {
            console.log(passengers[i]);
        } 
    }
}