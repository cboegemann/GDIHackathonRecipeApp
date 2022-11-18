import ApiAuthorzationRoutes from './components/api-authorization/ApiAuthorizationRoutes';

//counter, fetchdata and home provided by template 
import { Counter } from "./components/Counter";
import { FetchData } from "./components/FetchData";
import { Home } from "./components/Home";

//for Hack app
import SavedRecipesDetail from './components/SavedRecipesDetail';

import Error from './components/Error';
import Header from './components/Header';
import LoginForm from './components/LoginForm';
import RegisterForm from './components/RegisterForm';

const AppRoutes = [
    {
        index: true,
        element: <Home />
    },
    {
        path: '/counter',
        element: <Counter />
    },
    {
        path: '/fetch-data',
        requireAuth: false,
        element: <FetchData />
    },
    {
        path: '/saved-recipes-detail',
        element: <SavedRecipesDetail />
    },
    {
        path: '/error',
        element: <Error />
    },
    {
        path: '/header',
        element: <Header />
    },
    {
        path: '/login-form',
        element: <LoginForm />
    },
    {
        path: '/register-form',
        element: <RegisterForm />
    },
    ...ApiAuthorzationRoutes
];

export default AppRoutes;
