import axios from "./BasicUrl"
import { setRentals } from "../../redux/Actions";
import Swal from "sweetalert2";

export const getRentals = async () => {
    return await axios.get(`Rentals`)
}

export const getRentalsById = async (id) => {
    return await axios.get(`Rentals/${id}`)
}

export const postRentals = async (rental) => {
    return await axios.post(`Rentals`, rental)
}

export const putRentalsReturned = async (id) => {
    return await axios.put(`Rentals?id=${id}`)
}