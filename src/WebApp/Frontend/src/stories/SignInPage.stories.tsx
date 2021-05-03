import { Meta, Story } from "@storybook/react/types-6-0";
import SignInPage from "../pages/SignInPage";
import StoryRouter from 'storybook-react-router';

export default {
    title: "pages/SignInPage",
    decorators: [StoryRouter()],
    components: SignInPage,
} as Meta;

const Template: Story = () => <SignInPage />;

export const Default = Template.bind({});