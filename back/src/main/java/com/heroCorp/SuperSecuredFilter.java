package com.heroCorp;

import org.springframework.web.filter.GenericFilterBean;

import javax.servlet.FilterChain;
import javax.servlet.ServletException;
import javax.servlet.ServletRequest;
import javax.servlet.ServletResponse;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.util.Optional;

public class SuperSecuredFilter extends GenericFilterBean {

    public void doFilter(
            ServletRequest request,
            ServletResponse response,
            FilterChain chain) throws IOException, ServletException {

        HttpServletRequest httpRequest = asHttp(request);
        HttpServletResponse httpResponse = asHttp(response);

        Optional<String> token = Optional.ofNullable(httpRequest.getHeader("token"));

        if (token.orElseGet(()->"Villain").equals("ASuperSecuredToken")) {
            chain.doFilter(request, response);
        } else httpResponse.sendError(HttpServletResponse.SC_UNAUTHORIZED, "You don't have the token header... Are you a villain?");

    }

    private HttpServletRequest asHttp(ServletRequest request) {
        return (HttpServletRequest) request;
    }

    private HttpServletResponse asHttp(ServletResponse response) {
        return (HttpServletResponse) response;
    }
}