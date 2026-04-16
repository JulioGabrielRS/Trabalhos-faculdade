import React, { useState } from "react";
import { StatusBar } from "expo-status-bar";
import LoginScreen from "./src/screens/LoginScreen";
import HomeScreen from "./src/screens/HomeScreen";
import { Usuario } from "./src/types";

export default function App() {
  const [usuarioLogado, setUsuarioLogado] = useState<Usuario | null>(null);

  return (
    <>
      <StatusBar style="dark" />
      {usuarioLogado ? (
        <HomeScreen
          usuario={usuarioLogado}
          onLogout={() => setUsuarioLogado(null)}
        />
      ) : (
        <LoginScreen onLoginSuccess={setUsuarioLogado} />
      )}
    </>
  );
}
