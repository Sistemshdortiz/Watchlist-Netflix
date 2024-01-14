<!-- src/components/Login.vue -->
<template>
    <div>
        <h2>Login</h2>
        <form @submit.prevent="login">
            <label for="username">Username:</label>
            <input type="text" id="username" v-model="username" required />
            <br />
            <label for="password">Password:</label>
            <input type="password" id="password" v-model="password" required />
            <br />
            <button type="submit">Login</button>
        </form>
    </div>
</template>

<script>

    export default {
        data() {
            return {
                username: '',
                password: '',
            };
        },
        methods: {
            async login() {
                // POST request using fetch with async/await
                const requestOptions = {
                    method: "POST",
                    headers: { "Content-Type": "application/json" },
                    body: JSON.stringify({ username: username, password: password })
                };
                const response = await fetch("https://jsonplaceholder.typicode.com/posts", requestOptions);
                const data = await response.json();
                this.postId = data.id;
            }
        },
    };
</script>