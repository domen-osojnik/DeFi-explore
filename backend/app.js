const express = require('express');
const app = express();
const bodyParser = require('body-parser');

//apply body-parser middleware to express
app.use(bodyParser.json()); // for parsing application/json
app.use(bodyParser.urlencoded({ extended: false })); // for parsing application/x-www-form-urlencoded
//app.use(multer()); // for parsing multipart/form-data

//all routes
const indexRoutes = require('./Routes/indexRoutes');
const usersRoutes = require('./Routes/usersRoutes');

//use routes
app.use('/', indexRoutes);
app.use('/users', usersRoutes);

//we use port 3000
const PORT = 3000;

//node index => launches server on port 5000
app.listen(PORT, () => console.log(`Server started on port: ${PORT}`));
