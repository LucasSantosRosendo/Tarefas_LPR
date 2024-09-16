import { initializeApp } from "https://www.gstatic.com/firebasejs/10.12.3/firebase-app.js";
import {
  getAuth,
  createUserWithEmailAndPassword,
} from "https://www.gstatic.com/firebasejs/10.12.3/firebase-auth.js";
import {
  getDatabase,
  ref,
  set,
} from "https://www.gstatic.com/firebasejs/10.12.3/firebase-database.js";

const firebaseConfig = {
  apiKey: "AIzaSyCBzItoPtnnZL3qZzaugxDwnzja2g_ddas",
  authDomain: "mescla-f9d00.firebaseapp.com",
  projectId: "mescla-f9d00",
  storageBucket: "mescla-f9d00.appspot.com",
  messagingSenderId: "442057041731",
  appId: "1:442057041731:web:a5d7208555136ba97531f6",
};

const app = initializeApp(firebaseConfig);
const auth = getAuth(app);
const database = getDatabase(app);

document.getElementById("submit").addEventListener("click", function (event) {
  event.preventDefault();

<<<<<<< HEAD
  if (!validarForm()) {
    return;
  }

=======
>>>>>>> 64a03d2f275de69edb54c0edb2190bb34400adb4
  const nome = document.getElementById("nome").value;
  const nascimento = document.getElementById("nascimento").value;
  const cpf = document.getElementById("cpf").value;
  const cidade = document.getElementById("cidade").value;
  const bairro = document.getElementById("bairro").value;
  const email = document.getElementById("email").value;
  const senha = document.getElementById("senha").value;

<<<<<<< HEAD
=======
  if (senha !== senha2) {
    alert("As senhas não coincidem!");
    return;
  }

>>>>>>> 64a03d2f275de69edb54c0edb2190bb34400adb4
  createUserWithEmailAndPassword(auth, email, senha)
    .then((userCredential) => {
      const user = userCredential.user;

      set(ref(database, "users/" + user.uid), {
        nome: nome,
        nascimento: nascimento,
        cpf: cpf,
        cidade: cidade,
        bairro: bairro,
        email: email,
      })
        .then(() => {
          alert("Conta criada e dados salvos com sucesso!");
          window.location.href = "login.html";
        })
        .catch((error) => {
          alert("Erro ao salvar os dados: " + error.message);
        });
    })
    .catch((error) => {
      const errorMessage = error.message;
      alert("Erro ao criar conta: " + errorMessage);
    });
});

<<<<<<< HEAD
function validarForm() {
  const nome = document.getElementById("nome").value.trim();
  const nascimento = document.getElementById("nascimento").value;
  const cpf = document.getElementById("cpf").value.trim();
  const cidade = document.getElementById("cidade").value.trim();
  const bairro = document.getElementById("bairro").value.trim();
  const email = document.getElementById("email").value.trim();
  const senha = document.getElementById("senha").value;
  const senha2 = document.getElementById("senha2").value;

  if (
    !nome ||
    !nascimento ||
    !cpf ||
    !cidade ||
    !bairro ||
    !email ||
    !senha ||
    !senha2
  ) {
    Erro("Todos os campos são obrigatórios!");
=======
function validarForm(event) {
  event.preventDefault();
  const email = document.getElementById('email').value;
  const senha = document.getElementById('senha').value;

  if (email === "") {
    Erro("Email e senha são obrigatórios!");
>>>>>>> 64a03d2f275de69edb54c0edb2190bb34400adb4
    return false;
  }

  const emailValidacao = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
  if (!emailValidacao.test(email)) {
    Erro("Por favor, insira um email válido.");
    return false;
  }

<<<<<<< HEAD
  const cpfValidacao = /^\d{3}\.\d{3}\.\d{3}-\d{2}$/;
  if (!cpfValidacao.test(cpf)) {
    Erro("Por favor, insira um CPF válido no formato 000.000.000-00.");
    return false;
  }

=======
>>>>>>> 64a03d2f275de69edb54c0edb2190bb34400adb4
  if (senha.length < 8) {
    Erro("A senha deve ter pelo menos 8 caracteres.");
    return false;
  }
<<<<<<< HEAD

  if (senha !== senha2) {
    Erro("As senhas não conferem.");
    return false;
  }

  return true;
}

=======
  
  
  login(event);
  return true;
}


>>>>>>> 64a03d2f275de69edb54c0edb2190bb34400adb4
function Erro(message, isError = true) {
  const errorMessageDiv = document.getElementById("error-message");
  errorMessageDiv.innerHTML = message;
  errorMessageDiv.style.color = isError ? "red" : "green";
  errorMessageDiv.style.display = "block";
<<<<<<< HEAD
}
=======
}
>>>>>>> 64a03d2f275de69edb54c0edb2190bb34400adb4