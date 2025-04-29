import axios from "./BasicUrl"
import { setCarTypes } from "../../redux/Actions"
import Swal from "sweetalert2"

export const getCarTypes = async () => {
    return await axios.get(`CarTypes`)
}