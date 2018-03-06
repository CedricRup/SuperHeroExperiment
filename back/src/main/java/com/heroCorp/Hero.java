package com.heroCorp;

public class Hero {
    private String name;
    private String eye;
    private final String alive;
    private final String appearances;
    private final String firstAppearance;
    private final String hair;
    private final String sex;
    private final String align;
    private final String id;
    private final String secret;

    public Hero(String name, String eye, String alive, String appearances, String firstAppearance, String hair, String sex, String align, String id, String secret) {

        this.name = name;
        this.eye = eye;
        this.alive = alive;
        this.appearances = appearances;
        this.firstAppearance = firstAppearance;
        this.hair = hair;
        this.sex = sex;
        this.align = align;
        this.id = id;
        this.secret = secret;
    }

    public String getName() {
        return name;
    }

    public String getEye() {
        return eye;
    }

    public String getAlive() {
        return alive;
    }

    public String getAppearances() {
        return appearances;
    }

    public String getFirstAppearance() {
        return firstAppearance;
    }

    public String getHair() {
        return hair;
    }

    public String getSex() {
        return sex;
    }

    public String getAlign() {
        return align;
    }

    public String getId() {
        return id;
    }

    public String getSecret() {
        return secret;
    }
}
