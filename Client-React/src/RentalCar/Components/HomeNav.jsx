import { NavLink } from "react-router-dom"

export const HomeNav = () => {

    return <nav className="homeNav">
        <img className="logo" src={`${process.env.PUBLIC_URL}/images/cars/logo-shaddow-s.png`}></img>
        <div className="links">
            <NavLink></NavLink>
            <NavLink to={"/LoginOrRegister/Login"}>התחברות/הרשמה</NavLink>
            <NavLink to={"/userZone/Cars"}>לצפייה ברכבים שלנו</NavLink>
        </div>
    </nav>
}