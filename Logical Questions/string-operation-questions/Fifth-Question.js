const passengers = ['Athul M', 'Ramesh', 'Bibin', 'Deepak', 'Hari', 'Hari', 'Ramu', 'Rajesh', 'Sojan', 'Ashwin', 'Ashwin', 'Karnan'];

for (let i = 0; i < passengers.length; i++) {
    for (let j = 0; j < passengers.length; j++) {
        if(passengers[i][j] == ' ') {
            console.log(passengers[i].slice(j,passengers[i].length));
        }   
    } 
}