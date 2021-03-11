const express = require('express');
const app = express();

//we check if we have PORT already declared in process.env otherwise we use 5000
const PORT = 5000;

//node index => launches server on port 5000
app.listen(PORT, () => console.log(`Server started on port: ${PORT}`));
