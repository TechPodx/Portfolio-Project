/*We are going define a custom component called StateProvider that uses 
the React Context API(createContext, useContext) and Reducer hook to provide 
state management capabilities to its child components.*/
import { createContext, useContext, useReducer } from "react";

export const StateContext = createContext(); // Creating object using createContext function from react

export const StateProvider = ({children, initialState, reducer}) => (
  <StateContext.Provider value={useReducer(reducer, initialState)}> 
    {children}
  </StateContext.Provider>
);

export const useStateProvider = () => useContext(StateContext); // Return the value of useContex of StateContext
