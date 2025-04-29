import axios from "axios";

const url = 'https://localhost:7181/api'

export const getUsers = async () => {
    return await axios.get(`${url}/Users`)
}

export const getUserTypes = async () => {
    return await axios.get(`${url}/UserType`)
}

export const addNewUser = async (user) => {
    console.log('user api', user);

    return await axios.post(`${url}/Users`, user)
}

export const getRentals = async () => {
    return await axios.get(`${url}/Rentals`)
}

export const getDriveTypes = async () => {
    return await axios.get(`${url}/DriveTypes`)
}

export const getCars = async () => {
    return await axios.get(`${url}/Cars`)
}

export const updateCarDetailds = async (id, car) => {
    return await axios.put(`${url}/Cars?id=${id}`, car)
}

export const addReturnCar = async (ret) => {
    return await axios.post(`${url}/Returns`, ret)
}


export const getRentalsById = async (id) => {
    return await axios.get(`${url}/Rentals/${id}`)
}



