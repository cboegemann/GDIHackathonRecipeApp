import './App.css';
import React from 'react';

//import React, { Component } from 'react';
import { Route, Routes } from 'react-router-dom';
import AppRoutes from './AppRoutes';
import AuthorizeRoute from './components/api-authorization/AuthorizeRoute';
import { Layout } from './components/Layout';
import './custom.css';

import LandingPage from './pages/LandingPage';
import RecipeListPage from './pages/RecipeListPage';
import SavedRecipesPage from './pages/SavedRecipesPage';
import AboutUsPage from './pages/AboutUsPage';

import SavedRecipesDetail from './components/SavedRecipesDetail';

import Error from './components/Error';
import Header from './components/Header';
import LoginForm from './components/LoginForm';
import RegisterForm from './components/RegisterForm';

/*below is from template
export default class App extends Component {
  static displayName = App.name;

  render() {
    return (
      <Layout>
        <Routes>
          {AppRoutes.map((route, index) => {
            const { element, requireAuth, ...rest } = route;
            return <Route key={index} {...rest} element={requireAuth ? <AuthorizeRoute {...rest} element={element} /> : element} />;
          })}
        </Routes>
      </Layout>
    );
  }
}
*/

function App() {
    return (
        <main className="App">
            <Header />

            <Routes>
                <Route path='/' element={<LandingPage />} />
                <Route path='login' element={<LoginForm />} />
                <Route path='about' element={<AboutUsPage />} />
                <Route path='saved-recipes' element={<SavedRecipesPage />} />
                <Route path='recipes' element={<RecipeListPage />} />

                <Route path='register' element={<RegisterForm />} />

                {/* for testing only */}
                <Route path='detail' element={<SavedRecipesDetail />} />
                {/* for testing only */}

                <Route element={Error} />
                {/* Error component isn't rendering when I use an incorrect path */}
            </Routes>
        </main>
    );
}

export default App;